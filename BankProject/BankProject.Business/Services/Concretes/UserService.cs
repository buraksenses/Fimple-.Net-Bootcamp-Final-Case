﻿using AutoMapper;
using BankProject.API.DTOs.User;
using BankProject.Business.Services.Interfaces;
using BankProject.Data.Entities;
using BankProject.Data.Repositories.Interfaces;

namespace BankProject.Business.Services.Concretes;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<GetUserRequestDto> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        var userDto = _mapper.Map<GetUserRequestDto>(user);

        return userDto;
    }

    public async Task CreateAsync(CreateUserRequestDto requestDto)
    {
        var user = _mapper.Map<User>(requestDto);

        await _repository.CreateAsync(user);
    }

    public async Task UpdateAsync(Guid id, UpdateUserRequestDto requestDto)
    {
        var user = await _repository.GetByIdAsync(id);

        user = _mapper.Map<User>(requestDto);

        await _repository.UpdateAsync(id, user);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }
    
}