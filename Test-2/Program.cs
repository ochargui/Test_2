using System;

namespace Test_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            SIRENValidation validator = new SIRENValidation();

            Console.WriteLine("Entrez un numéro SIREN : ");
            string siren = Console.ReadLine();

            if (validator.ValidateSIREN(siren))
                Console.WriteLine("Le numéro SIREN est valide.");
            else
                Console.WriteLine("Le numéro SIREN est invalide.");



            SIRETValidation validatorSERIT = new SIRETValidation();

            Console.WriteLine("Entrez un numéro SIRET : ");
            string siret = Console.ReadLine();

            if (validatorSERIT.CheckSiretValidity(siret))
                Console.WriteLine("Le numéro SIRET est valide.");
            else
                Console.WriteLine("Le numéro SIRET est invalide.");

            Console.ReadKey();
            Console.ReadLine();
        }
    }


}