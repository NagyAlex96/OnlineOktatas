using System.Text;

namespace Ora_001
{
    public class OwnFileReader
    {
        public static List<Employee> LoadData(string path)
        {
            List<Employee> employees;

            if (File.Exists(path))
            {
                employees = new List<Employee>();

                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] sor = reader.ReadLine().Split('#');

                        switch (sor[0].ToLower())
                        {
                            case "manager":
                                employees.Add(new Manager(int.Parse(sor[4]), sor[1], sor[2], double.Parse(sor[3])));
                                break;
                            case "worker":
                                employees.Add(new Worker(sor[1], sor[2], double.Parse(sor[3])));
                                break;
                            default: break;
                        }
                    }
                }

                return employees;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
