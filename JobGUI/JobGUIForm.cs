
public partial class JobGUIForm : Form
{
    const string TXT = "C:\\Users\\juhas\\source\\repos\\CSHARP250610\\JobGUI\\resources\\job_market.txt";

    private List<Job> jobs = [];

    public JobGUIForm()
    {
        ListInit();
        InitializeComponent();
        this.Load += JobGUIForm_Load;
        btnSzuresEsSzamitas.Click += BtnSzuresEsSzamitas_Click;
        btnEredetiAllapot.Click += BtnEredetiAllapot_Click;
    }

    private void BtnEredetiAllapot_Click(object? sender, EventArgs e)
    {
        DgvFeltolt();
        cbxMunkakorok.SelectedIndex = -1;
        chxProgNyelv.Checked = false;
        lblAvgHuf.Visible = false;
        btnEredetiAllapot.Enabled = false;
    }

    private void BtnSzuresEsSzamitas_Click(object? sender, EventArgs e)
    {
        lblAvgHuf.Visible = true;
        DgvFeltolt((string)cbxMunkakorok.SelectedItem, chxProgNyelv.Checked);
        btnEredetiAllapot.Enabled = true;
    }

    private void JobGUIForm_Load(object? sender, EventArgs e)
    {
        DgvFeltolt();
        CbxInint();
    }

    private void DgvFeltolt(string kivMunkakor = null, bool csakProg = false)
    {
        dgvJobs.Rows.Clear();

        List<Job> szurtLista = jobs;
        if (kivMunkakor is not null)
            szurtLista = jobs.Where(j => j.JobRole == kivMunkakor).ToList();
        if (csakProg is true)
            szurtLista = szurtLista
                .Where(j => j.RequiredSkill.Name == "Python" 
                || j.RequiredSkill.Name == "JavaScript")
                .ToList();

        foreach (var job in szurtLista)
        {
            dgvJobs.Rows.Add(job.JobRole, job.Industry.Name, job.AIAdoptionLevel, job.AutomationRisk, job.RequiredSkill.Name);
        }

        bool konvertalhato = double.TryParse(txtArfolyam.Text, out double arfolyam);

        if (konvertalhato is false)
            MessageBox.Show(
                caption: "Hiba!",
                text: "Hibás árfolyam!",
                icon: MessageBoxIcon.Error,
                buttons: MessageBoxButtons.OK);
        else
        {
            lblAvgHuf.Text =
                $"{szurtLista.Average(j => j.SalaryUSD)
                * arfolyam:0} HUF";
        }
    }

    private void ListInit()
    {
        using StreamReader sr = new(TXT);
        _ = sr.ReadLine();
        while (!sr.EndOfStream) jobs.Add(new(sr.ReadLine()));
    }

    private void CbxInint()
    {
        var munkakorok = jobs.Select(j => j.JobRole).Distinct().Order();
        foreach (var munkakor in munkakorok)
            cbxMunkakorok.Items.Add(munkakor);
    }
}
