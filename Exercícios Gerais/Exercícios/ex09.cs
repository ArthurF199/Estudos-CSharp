namespace Exercícios_Gerais.Exercícios
{
    internal class ex09
    {
        public static void Executar()
        {
            int attempts = 0;
            string username = "admin";
            string password = "1234";

            while (attempts < 3)
            {   
                Console.Write("Usuário: ");
                string userLogin = Console.ReadLine();

                Console.Write("Senha: ");
                string userPassword = Console.ReadLine();


                if (userLogin == username && userPassword == password)
                {
                    Console.WriteLine("Login bem-sucedido");
                    return;
                }


                Console.WriteLine($"Tente novamente ({2 - attempts} tentativas restantes.)");
                attempts++;
            }

            Console.WriteLine("Acesso bloqueado");
        }
    }
}