
        //1.
        Dictionary<int, string> telebeler = new Dictionary<int, string>()
        {
            { 1, "aydan" },
            { 2, "fatime" },
            { 3, "xanim" },
            { 4, "kenan" },
            { 5, "senan" }
        };

        bool sistem = true;
        while (sistem)
        {
            Console.WriteLine("menyu");
            Console.WriteLine("1. telebe elave et");
            Console.WriteLine("2. telebeni id ile axtar");
            Console.WriteLine("3. butun telebeleri goster");
            Console.WriteLine("4. cixis");
            Console.Write("secim daxil edin: ");
            string secim = Console.ReadLine();
    Console.WriteLine();

    switch (secim)
            {
                case "1":
                    Console.Write("telebe id sini daxil edin: ");
                    if (int.TryParse(Console.ReadLine(), out int yeniId))
                    {
                        if (telebeler.ContainsKey(yeniId))
                        {
                            Console.WriteLine("bu id movcuddu");
                    Console.WriteLine();
                }
                        else
                        {
                            Console.Write("telebe adini daxil edin: ");
                            string ad = Console.ReadLine();
                            telebeler.Add(yeniId, ad);
                            Console.WriteLine("telebe elave olundu");
                    Console.WriteLine();
                }
                    }
                    break;

                case "2":
                    Console.Write("axtarilacaq id ni daxil edin: ");
                    if (int.TryParse(Console.ReadLine(), out int axtarisId))
                    {
                        if (telebeler.TryGetValue(axtarisId, out string tapilanAd))
                        {
                            Console.WriteLine($"telebe: id: {axtarisId}, ad: {tapilanAd}");
                    Console.WriteLine();
                }
                        else
                        {
                            Console.WriteLine("bu id ile telebe tapilmadi");
                    Console.WriteLine();
                }
                    }
                    break;

                case "3":
                    Console.WriteLine("\n--- telebelerin siyahisi ---");
                    foreach (var telebe in telebeler)
                    {
                        Console.WriteLine($"id: {telebe.Key}, ad: {telebe.Value}");
                Console.WriteLine();
            }
                    break;

                case "4":
                    sistem = false;
                    break;
            Console.WriteLine();

        default:
                    Console.WriteLine("try again :P ");
            Console.WriteLine();
            break;
            }
        }

//2.
Console.WriteLine();
Console.WriteLine("fiqur sec: 1) daire  2) duzbucaqli  3) ucbucaq");
        double sahe = 0;
string fiqurSecim = Console.ReadLine();
switch (fiqurSecim)
        {
            case "1":
                Console.Write("dairenin radiusunu daxil edin: ");
                double.TryParse(Console.ReadLine(), out double r);
                sahe = Math.PI * Math.Pow(r, 2);
                break;
            case "2":
                Console.Write("duzbucaqlinin enini daxil edin: ");
                double.TryParse(Console.ReadLine(), out double en);
                Console.Write("duzbucaqlinin uzunlugunu daxil edin: ");
                double.TryParse(Console.ReadLine(), out double uzunluq);
                sahe = en * uzunluq;
                break;
            case "3":
                Console.Write("ucbucaqlinin 1-ci terefi: ");
                double.TryParse(Console.ReadLine(), out double a);
                Console.Write("ucbucaqlinin 2-ci terefi: ");
                double.TryParse(Console.ReadLine(), out double b);
                Console.Write("ucbucaqlinin 3-cu terefi: ");
                double.TryParse(Console.ReadLine(), out double c);

                double p = (a + b + c) / 2;
                sahe = Math.Sqrt(p*(p-a) *(p-b) *(p-c));
        Console.WriteLine();
        break;
            default:
                Console.WriteLine("yanlus secim");
                break;
        }
        Console.WriteLine($"sahe: {Math.Round(sahe, 2)}");

//3.
Console.WriteLine();
List<int> ededler = new List<int>();

        Console.WriteLine("10 eded daxil edin:");
        for (int i = 0; i < 10; i++)
        {
            int.TryParse(Console.ReadLine(), out int daxilEdilen);
            ededler.Add(daxilEdilen);
        }
        int max = ededler[0];
        int min = ededler[0];
        int cutSayi = 0;
        int tekSayi = 0;
        foreach (int eded in ededler)
        {
            max = Math.Max(max, eded);
            min = Math.Min(min, eded);
            if (eded % 2 == 0)
                cutSayi++;
            else
                tekSayi++;
        }

        Console.WriteLine($"\nen boyuk eded: {max}");
Console.WriteLine();
Console.WriteLine($"en kicik eedd: {min}");
Console.WriteLine();
Console.WriteLine($"cut eded sayi: {cutSayi}");
Console.WriteLine();
Console.WriteLine($"tek eded sayi: {tekSayi}");
Console.WriteLine();

//4.
Console.WriteLine();
Random randomGenerator = new Random();
        int gizliEded = randomGenerator.Next(0, 101);
        int texmin;
        Console.WriteLine("0 ve 100 arasi ededi tap");
        do
        {
    Console.WriteLine();
    Console.Write("random eded daxil et");
            int.TryParse(Console.ReadLine(), out texmin);
            if (texmin > gizliEded)
            {
                Console.WriteLine("daha kicik eded cehd edin.");
        Console.WriteLine();
    }
            else if (texmin < gizliEded)
            {
                Console.WriteLine("daha boyuk eded cehd edin.");
        Console.WriteLine();
    }
        } while (texmin != gizliEded);
        Console.WriteLine("congrats （＞O＜；）");
    