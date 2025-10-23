using System;
using System.Linq;

class Program
{


    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Login/Registration Page ===");
            Console.WriteLine("1. Login (Giriş Yap)");
            Console.WriteLine("2. Signup (Kayıt Ol)");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    var hasta = LoginPatient();
                    if (hasta != null)
                        Dashboard(hasta); //login başarılıysa dashboard'a yönlendir
                    break;
                case "2":
                    RegisterPatient();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    Console.ReadKey();
                    break;
            }
        }
    }






    // DASHBOARD MENÜSÜ
    static void Dashboard(Patient patient)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Dashboard ===");
            Console.WriteLine($"Hoş geldiniz, {patient.FirstName} {patient.LastName}!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Account Manager");
            Console.WriteLine("2. Department Type");
            Console.WriteLine("3. Hospital Location");
            Console.WriteLine("4. Advanced Filters");
            Console.WriteLine("5. Günlük Randevular");
            Console.WriteLine("6. Logout");
            Console.WriteLine("------------------------------");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "6")
                return; // Logout, ana menüye döner
            else
            {
                Console.WriteLine("Bu özellik henüz aktif değil.");
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }




   
    // KAYIT OL
    static void RegisterPatient()
    {
        Console.Clear();
        Console.WriteLine("=== Kayıt Ol ===");

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Ad: ");
        string name = Console.ReadLine();

        Console.Write("Şifre: ");
        string password = Console.ReadLine();

        using (var context = new ClinicContext())
        {
            // Email daha önce var mı kontrolü
            if (context.Patients.Any(p => p.Email == email))
            {
                Console.WriteLine("Bu email zaten kayıtlı!");
                Console.ReadKey();
                return;
            }

            Patient newPatient = new Patient
            {
                Email = email,
                FirstName = name,
                Password = password
            };

            context.Patients.Add(newPatient);
            context.SaveChanges();
        }
        Console.WriteLine("Kayıt başarılı! Giriş yapabilirsiniz.");
        Console.ReadKey();
    }






    // GİRİŞ YAP
    static Patient LoginPatient()
    {
        Console.Clear();
        Console.WriteLine("=== Giriş Yap ===");

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Şifre: ");
        string password = Console.ReadLine();

        using (var context = new ClinicContext())
        {
            var patient = context.Patients.FirstOrDefault(p => p.Email == email && p.Password == password);
            if (patient != null)
            {
                Console.WriteLine($"Hoş geldiniz, {patient.FirstName}!");
                Console.ReadKey();
                return patient;
            }
            else
            {
                Console.WriteLine("Email veya şifre hatalı!");
                Console.ReadKey();
                return null;
            }
        }
    }
}