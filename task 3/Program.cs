   Console.Write("Eded daxil edin: ");
        int eded = Convert.ToInt32(Console.ReadLine());

        if (eded > 0)
        {
            Console.WriteLine("Eded musbetdir");
        }
        else if (eded < 0)
        {
            Console.WriteLine("Eded menfidir");
        }
        else
        {
            Console.WriteLine("Eded sifirdir");
        }
