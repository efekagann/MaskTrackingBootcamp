using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Conrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person) { }
    public List<Person> GetPerson()
    {
        return null;
    }
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync
            (
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;

    }
}
