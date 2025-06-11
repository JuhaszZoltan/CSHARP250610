internal class Job
{
    public string AIAdoptionLevel { get; set; }
    public string AutomationRisk { get; set; }
    public string CompanySize { get; set; }
    public Industry Industry { get; set; }
    public string JobGrowthProjection { get; set; }
    public string JobRole { get; set; }
    public string Location { get; set; }
    public bool RemoteFriendly { get; set; }
    public RequiredSkill RequiredSkill { get; set; }
    public double SalaryUSD { get; set; }

    public override string ToString() =>
        $"{Industry.Name.ToUpper()} iparág - " +
        $"{JobRole} munkakör - " +
        $"{SalaryUSD:0} USD éves fizetés\n" +
        $"{(RemoteFriendly ? "" : "NEM ")}HO-barát munkahely";

    public Job(string r)
    {
        var v = r.Split(';');
        AIAdoptionLevel = v[0];
        AutomationRisk = v[1];
        CompanySize = v[2];
        Industry = new(int.Parse(v[3]), v[4]);
        JobGrowthProjection = v[5];
        JobRole = v[6];
        Location = v[7];
        RemoteFriendly = v[8] == "Yes";
        RequiredSkill = new(int.Parse(v[9]), v[10]);
        SalaryUSD =  Math.Round(double.Parse(v[11]));
    }
}