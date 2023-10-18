using System;

namespace ExerContato
{
    internal class Program
    {
        public static Contact InserctContact()
        {
            Console.WriteLine(" Inserir Contato");
            Console.WriteLine("Informe o nome do contato: ");
            string name = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("Informe o telefone do contato: ");
            int telephone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a idade do contato: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Sexo do contato: ");
            string gender = Convert.ToString(Console.ReadLine()).ToLower();

            return new Contact(name, telephone, age, gender);
        }

        public static void PrintContact(Contact[] contact, int cont)
        {
            Console.WriteLine("Contatos");
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine(contact[i].ToString());
            }
        }

        public static void SearchContact(Contact[] contact, int cont)
        {
            Console.WriteLine("Procurar contato");
            Console.WriteLine("Informe o nome do contato");
            string searchContact = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                if (searchContact.Equals(contact[i].Name))
                {
                    Console.WriteLine(contact[i].ToString());
                }
            }
        }

        public static void DeletedContact(Contact[] contact, int cont)
        {
            Console.WriteLine("Procurar contato");
            Console.WriteLine("Informe o nome do contato");
            string deletedContact = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                if (deletedContact.Equals(contact[i].Name))
                {
                    contact[i] = null;
                }
            }
        }

        public static void MessageInvalid()
        {
            Console.WriteLine("Inválid Option");
        }

        static void Main(string[] args)
        {
            Contact[] contact = new Contact[5];
            string option = "";
            int cont = 0;

            while(option != "0")
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("[ 1 ] - Adicionar Contato");
                Console.WriteLine("[ 2 ] - Imprimir Contato");
                Console.WriteLine("[ 3 ] - Buscar Contato");
                Console.WriteLine("[ 4 ] - Remover Contato");
                Console.WriteLine("[ 0 ] - Sair");
                option = Convert.ToString(Console.ReadLine());

                switch (option)
                {
                    case "1":
                        if(cont < 5)
                        {
                            contact[cont] = InserctContact();
                            cont++;
                        }
                        else
                        {
                            Console.WriteLine("Agenda cheia");
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        if(cont == 0)
                        {
                            Console.WriteLine("Agenda vazia");
                        }
                        else
                        {
                            PrintContact(contact, cont);
                        }
                        break;
                    case "3":
                        if(cont == 0)
                        {
                            Console.WriteLine("Agenda vazia");
                        }
                        else
                        {
                            SearchContact(contact, cont);
                        }
                        break;
                    case "4":
                        if (cont == 0)
                        {
                            Console.WriteLine("Agenda vazia");
                        }
                        else
                        {
                            DeletedContact(contact, cont);
                            cont--;
                        }
                        break;
                    case "5":
                        MessageInvalid();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}