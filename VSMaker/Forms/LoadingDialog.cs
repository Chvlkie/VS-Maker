using VSMaker.Data;

namespace VSMaker.Forms
{
    public partial class LoadingDialog : Form
    {
        private Mainform mainform;
        private LoadingDataEnum loadType;

        public LoadingDialog(Mainform mainform, LoadingDataEnum loadType)
        {
            this.mainform = mainform;
            this.loadType = loadType;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            switch (loadType)
            {
                case LoadingDataEnum.UnpackRom:
                    Text = "Unpacking ROM Data";
                    UnpackRom();
                    break;

                case LoadingDataEnum.LoadRomData:
                    Text = "Loading ROM Data";
                    LoadRomData();
                    break;

                case LoadingDataEnum.UnpackNarcs:
                    Text = "Unpacking Essential NARCs";
                    UnpackNarcs();
                    break;

                case LoadingDataEnum.SetupEditor:
                    Text = "Setting Up Editor";
                    SetupEditor();
                    break;

                case LoadingDataEnum.SaveRom:
                    Text = "Saving ROM";
                    SaveRom();
                    break;

                default:
                    FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
                    Close();
                    break;
            }
        }

        public async Task UnpackRom()
        {
            await Task.Delay(200);
            await Task.Run(() => mainform.BeginUnpackRomData());
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task LoadRomData()
        {
            await Task.Delay(200);
            await Task.Run(() => mainform.BeginLoadRomData());
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task UnpackNarcs()
        {
            await Task.Delay(200);
            await Task.Run(() => mainform.BeginUnpackNarcs());
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task SetupEditor()
        {
            await Task.Delay(200);
            await Task.Run(() => mainform.BeginSetupEditor());
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task SaveRom()
        {
            await Task.Delay(200);
            await Task.Run(() => mainform.BeginSaveRomChanges());
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        private void LoadingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}