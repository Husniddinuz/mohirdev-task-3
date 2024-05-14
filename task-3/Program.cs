System.Console.Write("Tug'ilgan yilingizni kiriting: ");
int tugilganYil = System.Convert.ToInt32(System.Console.ReadLine());

int joriyYil = System.DateTime.Now.Year;
int yosh = joriyYil - tugilganYil;
int kunlardaYosh = yosh * 365;

System.Console.WriteLine($"Yoshingiz kunlarda: {kunlardaYosh}");