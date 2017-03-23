using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            string saisieLog;
            string saisieMP;
            while (!ok)
            {
                Console.WriteLine("saisir un login :");
                saisieLog = Console.ReadLine();
                try
                {
                    
                   ok= veriformat(saisieLog);

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("saisir un mot de passe :");
                saisieMP = Console.ReadLine();

                try
                {
                    ok = veriformatMP(saisieMP);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }


            Console.WriteLine("votre compte a bien été crée");
            Console.ReadKey();

        }
        static bool veriformat(string Login)
        {
            if (Login.Length >= 5)
            {
                return true;
            }
            else
            {
                throw new FormatException("votre mot de passe doir comporter au moins 5 caractères");

            }
        }
        static bool veriformatMP(string MotPasse)
        {
            if (MotPasse.Length >= 6 && MotPasse.Length <= 12 && MotPasse[0] != ' ' && MotPasse[MotPasse.Length - 1] != ' ')
            {
                return true;
            }
            else
            {
                throw new FormatException("votre mot de passe doir comporter entre 6 et 12 caractères et ne pas commencer par un espace au début et à la fin");


            }
        }
    }
}
