using Business.Conrete;
using Entities.Concrete;

Console.WriteLine("Kimlik Bilgileriniz Kontrol Ediliyor");

Person person = new Person();
person.NationalIdentity = 32903294866;
person.FirstName = "KAĞAN";
person.LastName = "EFE";
person.DateOfBirthYear = 2000;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
