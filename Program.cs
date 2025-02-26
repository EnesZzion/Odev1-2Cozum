using Odev1Cozum.Class;
//------------------------------------------ ODEV 1 COZUM ---------------------------------------------------
//"BMW, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
BMW araba1 = new BMW();

araba1.model = "BMW";
araba1.vites = "Düz";
araba1.ArabaOzellik(araba1.model, araba1.vites);

//"MERCEDES, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
MERCEDES araba2 = new MERCEDES();

araba2.model = "Mercedes";
araba2.vites = "Otomatik";
araba2.ArabaOzellik(araba2.model, araba2.vites);

//"Togg, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
Togg araba3 = new Togg();

araba3.ArabaOzellik("Togg", "Otomatik");

//"Toyota, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
Toyota araba4 = new Toyota();

araba4.model = "Toyota";
araba4.vites = "Düz";
araba4.ArabaOzellik(araba4.model, araba4.vites);

//"Audi, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
Audi araba5 = new Audi();

araba5.ArabaOzellik("Audi", "Düz");

//"Porche, Araba sınıfından türediği için Araba sınıfının özelliklerine ve metotlarına erişebilir."
Porche araba6 = new Porche();

araba6.model = "Porche";
araba6.vites = "Otomatik";
araba6.ArabaOzellik(araba6.model, araba6.vites);













