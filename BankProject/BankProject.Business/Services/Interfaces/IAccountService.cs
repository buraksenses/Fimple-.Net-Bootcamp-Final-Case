﻿using BankProject.Business.DTOs.Account;

namespace BankProject.Business.Services.Interfaces;

public interface IAccountService
{
   Task<float> GetBalanceByAccountIdAsync(Guid id);

   Task CreateAccountAsync(CreateAccountRequestDto requestDto);

   Task UpdateBalanceByAccountIdAsync(Guid id, float balance);

   Task DepositAsync(Guid accountId, float amount);

   Task WithdrawAsync(Guid accountId, float amount);

   Task InternalTransferAsync(Guid senderId, Guid receiverId, float amount);

   Task ExternalTransferAsync(Guid senderId, Guid receiverId, float amount);

   Task MakePayment(Guid id, float amount);
}