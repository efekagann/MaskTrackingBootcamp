﻿using Business.Abstract;
using Entities.Concrete;

namespace Business.Conrete;

public class PttManager : ISupplierService
{
    IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " için maske verildi.");
        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske verilemedi");
        }
    }
}
