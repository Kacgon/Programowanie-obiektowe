using Lab_4_OOP;

Rectangle rectangle = new Rectangle(2, 4, 5, 7);
Triangle triangle = new Triangle(4, 7, 12, 4);
Circle circle = new Circle(9, 12, 5, 8);

List<Ksztalt> ksztalty = new List<Ksztalt>();
ksztalty.Add(rectangle);
ksztalty.Add(circle);
ksztalty.Add(triangle);

foreach (Ksztalt ksztalt in ksztalty)
{
    ksztalt.Draw();
}

Osoba osoba1 = new Osoba("kac", "gonc", "70041049175");
Osoba osoba2 = new Osoba("qwe", "fxd", "89080298811");
Osoba osoba3 = new Osoba("gasd", "afs", "50011795952");
Osoba osoba4 = new Osoba("asd", "asd", "90120178675");
Osoba osoba5 = new Osoba("bxcf", "czx", "05230671954");

List<IOsoba> osobas = new List<IOsoba>();

osobas.Add(osoba1);
osobas.Add(osoba2);
osobas.Add(osoba3);
osobas.Add(osoba4);
osobas.Add(osoba5);