﻿using BankProject.Core.Enums;
using BankProject.Data.Entities;

namespace BankProject.Data.Repositories.Interfaces;

public interface ILoanApplicationRepository
{
    Task CreateLoanApplicationAsync(LoanApplication loanApplication);

    Task<LoanApplication?> GetLoanApplicationByIdAsync(Guid id);

    Task UpdateLoanApplicationStatusAsync(LoanApplication application, LoanApplicationStatus status);
}