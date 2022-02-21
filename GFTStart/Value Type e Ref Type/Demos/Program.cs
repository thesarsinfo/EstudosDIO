using static System.Console;
using Demos.Classes;
using System.Collections.Generic;
using Demos.Struct;

namespace Demos
{
    public class Program
    {
        
        static void Demo12()
        {
            Number a = new(2);
            Number b = new(2);
            WriteLine((a.Numbers == b.Numbers)?"igual":"Desigual");
        }
        static void Demo11()
        {
            PeopleObject p1 = new();
/*
            p1.Name = "Saraiva";
            p1.Age = 30;
            */
            //defaulf serve para inicializar a struct com o valor default
                //p1.AddressPeople = default;
            p1.AddressPeople = new AddressStruct()
            {
                Address = "Rua teste",
                Number = 300,
                ZipCode = "00000-000",
                City = "São Paulo"
            };
            WriteLine("Fim");
        }
        static void Demo10()
        {
            var names = new string[] {"José","Maria","Jorge","Getulio","Claudemar"};
            WriteLine("Digite o nome que deseja alterar");
            string consultName = ReadLine();            
            var index = SearchName(names,consultName);
            if (index >= 0)
            {
                WriteLine("Digite o novo nome para alterar");
                string newName = ReadLine();
                names[index] = newName;
                WriteLine($@" A lista de nomes alterada é:
                {string.Join(", \n",names)}
            ");
            }
            else
            {
                WriteLine("Nome não encontrado");
            }
            
            
        }
         static void Demo9()
        {
            int a = 5;
            Add20Part(ref a);
            WriteLine($"O valor de a é {a}!");
        }
        static void Demo8()
        {
            List<StructPeople> peoples = new()
            {
                new StructPeople(){Name = "Thiago"},
                new StructPeople(){Name = "Jose"},
                new StructPeople(){Name = "Maria"},
                new StructPeople(){Name = "Ricardo"},
                new StructPeople(){Name = "Saraiva"}
            };
            WriteLine("Digite o nome da pessoa que gostaria de localizar:");
            var namePeople = ReadLine();
            var findName = new StructPeople(){Name = namePeople};
            var consult = FindNamePeople(peoples,findName);
            WriteLine($@"
            O nome {
                (consult ? namePeople + " foi localizada" : namePeople + "não foi encontrado")}
            ");
        }
        static void Demo7()
        {
            List<People> peoples = new()
            {
                new Classes.People(){Name = "Thiago"},
                new People(){Name = "Jose"},
                new People(){Name = "Maria"},
                new People(){Name = "Ricardo"},
                new People(){Name = "Saraiva"}
            };
            WriteLine("Digite o nome da pessoa que gostaria de localizar:");
            var namePeople = ReadLine();
            var findName = new People(){Name = namePeople};
            var consult = FindNamePeople(peoples,findName);
            WriteLine($@"
            O nome {
                (consult ? namePeople + " foi localizada" : namePeople + "não foi encontrado")}
            ");
        }
        static void Demo6()
        {
            int[] numbers = new int[] {0,2,4,6,8};
            WriteLine($"Digite o numero que gostaria de encontrar ");
            var number = int.Parse(ReadLine());
            var indexFound = FindNumber(numbers,number);
            WriteLine($@"
                O número digitado está na posição 
                {(indexFound == -1?"Valor não encontrado":indexFound)}
            ");
        }
        static void Demo5()
        {
            var even = new int[] {0,2,4,6,8}; 
            ChangeToOdd(even);
            WriteLine($"Os impares {string.Join(",", even)}");
        }
        static void Demo4()
        {
            string name = "Thiago";
            ChangeName(name,"Saraiva");
            WriteLine($"O novo nome é {name}");
        }
        static void Demo3()
        {
            StructPeople p1 = new()
            {
                Document = "1234",
                Age = 30,
                Name = "Saraiva"
            };
            //Outra forma de instanciar
            StructPeople p = default;
            p.Name = "Jorge";
            p.Age = 34;
            p.Document = "1235";

            var p2 = p1;
    //por struct se de valor temos que retorna seu valor senão não ha 
    //alterações
            p1 = ChangeName(p1,"Thiago");
            WriteLine($@"
                Primeiro nome é {p1.Name}
                Segundo nome é {p2.Name}
            ");
        }
        static void Demo2()
        {
            People p1 = new();
            
            p1.Name = "Thiago";
            p1.Age = 34;
            p1.Document = "1234";
            //var p2 = p1; Copiamos a referencia e por assim sempre 
            //mudara os itens
            //Para corrigir isso criamos uma nova instancia.
            /*
            People p2 = new();
            p2.Name = p1.Name;
            p2.Age = p1.Age;
            p2.Document = p1.Document;
    */
            People p2 = p1.Clone();
            ChangeName(p1,"Jorge");
            WriteLine($@"
            O  nome é : {p1.Name} 
            e segunda pessoa é {p2.Name}
            ");
        }
        static void Demo()
        {
            var a = 10;
            a = Add20(a);
            WriteLine($"O valor da variavel é {a}");
        }
        public static int Add20(int a)
        {
            return a + 20;
        } 
            static void ChangeName(People p1, string newName)
        {
            p1.Name = newName;
        }
        static StructPeople ChangeName(StructPeople p1, string newName)
        {
            p1.Name = newName;
            return p1;
        }
        static void ChangeName(string name,string newName)
        {
            newName = name;
        }
        static void ChangeToOdd(int[] even)    
        {
            for (int i =0; i < even.Length; i++)
            {
                even[i] = even[i] + 1;
            }
        }
        static int FindNumber(int[] numbers, int number)
        {
            for (int i = 0 ; i < numbers.Length; i++)
            {
                if(numbers[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
        static bool FindNamePeople (List<People> People, People namePeople)
        {
            foreach (var element in People)
            {
                if (element.Name == namePeople.Name) return true;               
            }
            return false;
        }
        static bool FindNamePeople (List<StructPeople> People, StructPeople namePeople)
        {
            foreach (var element in People)
            {
                //nesse caso como se trata de uma lista e com struct embutido
                //temos de usar o operador equals para comparar suas referencias
                if (element.Equals(namePeople)) return true;               
            }
            return false;
        }
        static void Add20Part(ref int a )
        {
            a += 20;
        }
        static void ChangeNameByRef(string[] listNames,string actualName, string newName)
        {
            for(int i = 0; i < listNames.Length ; i++)
            {
                if(listNames[i] == actualName)
                {
                    listNames[i] = newName;
                }
            }
        }
        static int SearchName(string[] names, string name)
        {
            for(int i = 0; i < names.Length; i++)
            {
                if(names[i] == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main()
        {           
            
        }
    }
}
