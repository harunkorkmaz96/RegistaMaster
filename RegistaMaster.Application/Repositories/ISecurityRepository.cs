﻿using Microsoft.AspNetCore.Http;
using RegistaMaster.Domain.DTOModels.LoginModels;

namespace RegistaMaster.Application.Repositories;

public interface ISecurityRepository
{
  Task<string> Login(string userName , string password,string url);
  LoginDTO Login(PathString url);
  void Logout();
}
