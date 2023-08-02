using GDPIControl;
using MincifryCertificate.WinForms.Properties;

namespace MincifryCertificate.WinForms
{
    public partial class FormMain : Form
    {
        private readonly CertificateStore MachineStore = CertificateStore.MachineStore();
        private readonly CertificateStore UserStore = CertificateStore.UserStore();

        public FormMain()
        {
            InitializeComponent();
            DataBindings.Add("BackColor", Settings.Default, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            DataBindings.Add("ForeColor", Settings.Default, "ForeColor", true, DataSourceUpdateMode.OnPropertyChanged);
            Icon = Resources.Icon;
            Text += $" v{Application.ProductVersion}";
        }

        private static string GetCheck(bool check) => check ? "Установлен" : "Не установлен";

        private void Install(CertificateStore store)
        {
            store.InstallCertificate();
            RefreshUI();
        }

        private void RefreshUI()
        {
            var machine = MachineStore.Installed();
            B_InstallMachine.Enabled = !machine && Program.IsAdministrator;
            B_RemoveMachine.Enabled = machine && Program.IsAdministrator;
            TB_CheckMachine.Text = GetCheck(machine);

            var user = UserStore.Installed();
            B_InstallUser.Enabled = !user && !machine;
            B_RemoveUser.Enabled = user && !machine;
            TB_CheckUser.Text = machine ? "Установлен в системе" : GetCheck(user);
        }

        private void Remove(CertificateStore store)
        {
            store.RemoveCertificate();
            RefreshUI();
        }

        #region UIEvents

        private void B_InstallMachine_Click(object sender, EventArgs e)
        {
            Install(MachineStore);
        }

        private void B_InstallUser_Click(object sender, EventArgs e)
        {
            Install(UserStore);
        }

        private void B_RemoveMachine_Click(object sender, EventArgs e)
        {
            Remove(MachineStore);
        }

        private void B_RemoveUser_Click(object sender, EventArgs e)
        {
            Remove(UserStore);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void MI_About_Click(object sender, EventArgs e)
        {
            var F = new FormAbout();
            F.ShowDialog(this);
        }

        #endregion UIEvents
    }
}