List<Job> jobs = [];

const string TXT = "C:\\Users\\juhas\\source\\repos\\CSHARP250610\\JobsCLI\\resources\\job_market.txt";

const string SMALL = "C:\\Users\\juhas\\source\\repos\\CSHARP250610\\JobsCLI\\resources\\small.txt";

using StreamReader sr = new(TXT);
_ = sr.ReadLine();

while (!sr.EndOfStream) jobs.Add(new(sr.ReadLine()));

Console.WriteLine("5. feladat:");
for (int i = 0; i < 5; i++) Console.WriteLine(jobs[i] + "\n");

var f5prc = jobs.Count(j => j.RemoteFriendly) / (double)jobs.Count * 100;
Console.WriteLine($"Az állások {f5prc:0.0}%-a végezhető távolról\n");

var f6grps = jobs
    .Where(j => j.Industry.Name == "Technology")
    .GroupBy(j => j.JobRole)
    .OrderByDescending(g => g.Count());
Console.WriteLine("6. feladat:");
foreach (var grp in f6grps)
    Console.WriteLine($"{grp.Key}: {grp.Count()} hirdetés");


Console.WriteLine("7. feladat: file-ba írás");
var f7dts = jobs.Where(j => j.AutomationRisk == "High" && j.CompanySize == "Small");

using StreamWriter sw = new(SMALL);
int rn = 1;
foreach (var job in f7dts)
{
    sw.WriteLine($"{rn} {job.Location} - {job.SalaryUSD}");
    rn++;
}
