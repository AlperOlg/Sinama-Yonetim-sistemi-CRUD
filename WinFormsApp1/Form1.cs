using ConsoleApp5.Abstract;
using ConsoleApp5.Concrete;
using ConsoleApp5.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IFilmService _filmService;
        private readonly IYonetmenService _yonetmenService;

        public Form1(IFilmService filmService, IYonetmenService yonetmenService)
        {
            InitializeComponent();
            _filmService = filmService;
            _yonetmenService = yonetmenService;
        }
        public enum ModelClass
        {
            Film,
            Yonetmen
        }
        public async Task Listele(ModelClass model)
        {
            if (model == ModelClass.Film)
                dataGridView1.DataSource = await _filmService.GetAllAsync();
            else if (model == ModelClass.Yonetmen)
                dataGridView1.DataSource = await _yonetmenService.GetAllAsync();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
        }
        private void PanelDegitir(ModelClass model)
        {
            if (model == ModelClass.Film)
            {
                gbYonetmenIslem.Visible = false;
                gbFilmIslem.Visible = true;
            }
            else
            {
                gbFilmIslem.Visible = false;
                gbYonetmenIslem.Visible = true;
            }
        }
        ModelClass seciliolan = ModelClass.Film;
        bool isLoading = false;
        private async Task LoadDatas(ModelClass model) // bu metotu oluþturmamýn sebebi eðer btnFilmler ve btnYonetmenler butonlarýna hýzlýca basýlýrsa bir Listele metotu bitmeden diðer butondaki Listele metotu çalýþmaya çalýþýyordu böylece program hata fýrlatýyordu (TargetInvocationException) bunu çözmek için yükleme esnasýnda diðer bir butona basýlýrsa iþlem yapýlmamasýný istedim
        {
            if (isLoading)
            {
                MessageBox.Show($"'{model}' verileri yükleniyor, lütfen iþlem tamamlanana kadar bekleyin");
                return;
            }
            isLoading = true;
            try
            {
                PanelDegitir(model);
                await Listele(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: '{ex.Message}'", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { isLoading = false; }
        }
        private int GetValidID(string text, ModelClass model)
        {
            int ID;
            if (!int.TryParse(text, out ID) || ID <= 0) { throw new Exception($"{model} IDsi yanlýþ formatta girildi (ID giriþleri zorunlu) "); }
            return ID;
        }
        private async void btnFilmler_Click(object sender, EventArgs e)
        {
            seciliolan = ModelClass.Film;
            btnFilmler.BackColor = Color.Green;
            btnYonetmenler.BackColor = Color.Red;
            await LoadDatas(seciliolan);
        }

        private async void btnYonetmenler_Click(object sender, EventArgs e)
        {
            seciliolan = ModelClass.Yonetmen;
            btnYonetmenler.BackColor = Color.Green;
            btnFilmler.BackColor = Color.Red;
            await LoadDatas(seciliolan);
        }
        bool isAddPanelOpen = false;
        public void IslemPaneliAcKapa(ref bool isOpen)
        {
            if (isOpen == false)
            {
                gbIslemler.Visible = true;
                isOpen = true;
            }
            else
            {
                gbIslemler.Visible = false;
                isOpen = false;
            }
        }
        private void SetButtonVisible(bool visibility, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = visibility;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IslemPaneliAcKapa(ref isAddPanelOpen);
            SetButtonVisible(true, btnFilmEkle, btnYonetmenEkle);
            SetButtonVisible(false, btnFilmSil, btnFilmiGuncelle, btnYonetmenSil, btnYonetmenGuncelle, txtFilmID, lblfilmID, lblYonetmenIDy, txtYonetmenIDy);
        }

        private async void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtReleaseDate.Text) || string.IsNullOrWhiteSpace(txtYonetmenID.Text))
            {
                MessageBox.Show("Film eklemek için boþ bilgi býrakýlmamalý", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filmName = txtName.Text;
            DateTime releaseDate;
            if (!DateTime.TryParse(txtReleaseDate.Text, out releaseDate))
            {
                MessageBox.Show("Çýkýþ tarihi yanlýþ formatta yazýldý (gün-ay-yýl þeklinde giriþ yapýlmalý)", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int yonetmenID;
            if (!int.TryParse(txtYonetmenID.Text, out yonetmenID))
            {
                MessageBox.Show("YonetmenID yanlýþ formatta yazýldý", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Film eklenecekFilm = new() { Name = filmName, ReleaseDate = releaseDate, YonetmenID = yonetmenID };
            try
            {
                await _filmService.AddAsync(eklenecekFilm);
                MessageBox.Show($"{filmName} adlý film eklendi", "baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(seciliolan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: '{ex.Message}'", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void InfoGoster(string Text, Color color, int Tick)
        {
            lblInfo.Text = Text;
            lblInfo.ForeColor = color;
            lblInfo.Visible = true;
            timer1.Interval = Tick;
            timer1.Stop();
            timer1.Start();
        }
        bool isRemovePanelOpen = false;
        private void btnSil_Click(object sender, EventArgs e)
        {
            IslemPaneliAcKapa(ref isRemovePanelOpen);
            SetButtonVisible(true, btnFilmSil, btnYonetmenSil, txtFilmID, lblfilmID, lblYonetmenIDy, txtYonetmenIDy);
            SetButtonVisible(false, btnFilmEkle, btnFilmiGuncelle, btnYonetmenEkle, btnYonetmenGuncelle);
            InfoGoster("bir veriyi silmek için IDsini yazmak yeterlidir", Color.Firebrick, Tick: 5000);

        }

        private async void btnGetir_Click(object sender, EventArgs e)
        {
            await Listele(seciliolan);
        }

        private async void btnYonetmenEkle_Click(object sender, EventArgs e)
        {
            string yonetmenAd = txtYonetmenAd.Text;
            string yonetmenSoyad = txtYonetmenSoyad.Text;
            if (string.IsNullOrWhiteSpace(yonetmenAd) || string.IsNullOrWhiteSpace(yonetmenSoyad) || string.IsNullOrWhiteSpace(txtYonetmenYas.Text))
            {
                MessageBox.Show("Yonetmen eklemek için boþ bilgi býrakýlmamalý", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int yonetmenYas;
            if (!int.TryParse(txtYonetmenYas.Text, out yonetmenYas) || yonetmenYas <= 0)
            {
                MessageBox.Show("Yonetmenin yaþý yanlýþ formatta girildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Yonetmen eklenecekYonetmen = new() { Name = yonetmenAd, Surname = yonetmenSoyad, Age = yonetmenYas };
            try
            {
                await _yonetmenService.AddAsync(eklenecekYonetmen);
                MessageBox.Show($"'{yonetmenAd} {yonetmenSoyad}' adlý yönetmen eklendi", "baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(seciliolan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: '{ex.Message}'", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            timer1.Stop();
        }
        bool isUpdatePanelOpen = false;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            IslemPaneliAcKapa(ref isUpdatePanelOpen);
            SetButtonVisible(true, btnFilmiGuncelle, btnYonetmenGuncelle, txtFilmID, lblfilmID, lblYonetmenIDy, txtYonetmenIDy);
            SetButtonVisible(false, btnFilmEkle, btnFilmSil, btnYonetmenEkle, btnYonetmenSil);
            InfoGoster("bir veriyi güncellemek için IDsi dahil deðiþtirmek istediðiniz bütün verileri yazmak zorundasýn", Color.DarkCyan, Tick: 5000);
        }

        private async void btnFilmSil_Click(object sender, EventArgs e)
        {
            try
            {
                int filmID = GetValidID(txtFilmID.Text, ModelClass.Film);
                if (MessageBox.Show($"{filmID} IDli film silinecek, emin misin?", "soru", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                await _filmService.RemoveIDAsync(filmID);
                MessageBox.Show($"{filmID} IDli film silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(seciliolan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata oluþtu: {ex.Message}", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnFilmiGuncelle_Click(object sender, EventArgs e)
        {
            DateTime? _cikisTarih = null;
            try
            {
                int _filmID = GetValidID(txtFilmID.Text, ModelClass.Film);
                int _yonetmenID = GetValidID(txtYonetmenID.Text, ModelClass.Yonetmen);
                if (!string.IsNullOrWhiteSpace(txtReleaseDate.Text))
                    _cikisTarih = Convert.ToDateTime(txtReleaseDate.Text);
                await _filmService.UpdateFilmWithIDAsync(filmID: _filmID, filmAd: txtName.Text, cikisTarih: _cikisTarih, yonetmenID: _yonetmenID);
                MessageBox.Show($"{_filmID} IDli film güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(seciliolan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata oluþtu: {ex.Message}", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnYonetmenSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yonetmenID = GetValidID(txtYonetmenIDy.Text, ModelClass.Yonetmen);
                await _yonetmenService.RemoveIDAsync(yonetmenID);
                MessageBox.Show("Yönetmen silindi", "baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(ModelClass.Yonetmen);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata oluþtu: {ex.Message}", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnYonetmenGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int _yonetmenID = GetValidID(txtYonetmenIDy.Text, ModelClass.Yonetmen);
                int? _yonetmenYas = null;
                if (!string.IsNullOrWhiteSpace(txtYonetmenYas.Text))
                    _yonetmenYas = Convert.ToInt32(txtYonetmenYas.Text);
                await _yonetmenService.UpdateDirectorWithIDAsync(yonetmenID: _yonetmenID, yonetmenAdi: txtYonetmenAd.Text, yonetmenSoyadi: txtYonetmenSoyad.Text, yonetmenYasi: _yonetmenYas);
                MessageBox.Show($"{_yonetmenID} IDli yönetmen güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Listele(seciliolan);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata oluþtu: {ex.Message}", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
