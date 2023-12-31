﻿using BankProject.Business.Services.Interfaces;
using BankProject.Data.Entities;
using BankProject.Data.Repositories.Interfaces;

namespace BankProject.Business.Services.Concretes;

public class LoanService : ILoanService
{
    private readonly ILoanRepository _repository;

    public LoanService(ILoanRepository repository)
    {
        _repository = repository;
    }
    
    public async Task CreateLoanAsync(Loan loan)
    {
        await _repository.CreateAsync(loan);
    }
}