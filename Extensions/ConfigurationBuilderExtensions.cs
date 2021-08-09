using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace sqstr.Extensions
{
  public static class ConfigurationBuilderExtensions
  {
    public static void ConfigureKeyVault(this IConfigurationBuilder config)
    {
      var keyVaultEndpoint = "https://sqstr-key-vault.vault.azure.net/secrets";

      var secretClient = new SecretClient(new(keyVaultEndpoint), new DefaultAzureCredential());
      config.AddAzureKeyVault(secretClient, new KeyVaultSecretManager());
    }
  }
}