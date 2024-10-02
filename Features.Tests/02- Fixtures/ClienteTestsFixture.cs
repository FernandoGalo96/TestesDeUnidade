﻿using Features.Clientes;

namespace Features.Tests._02__Fixtures;

[CollectionDefinition(nameof(ClienteCollection))]
public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
{ }

public class ClienteTestsFixture : IDisposable
{
    public Cliente GerarClienteValido()
    {
        var cliente = new Cliente(
            Guid.NewGuid(),
            "Eduardo",
            "Pires",
            DateTime.Now.AddYears(-30),
            "edu@edu.com",
            true,
            DateTime.Now);

        return cliente;
    }

    public Cliente GerarClienteInValido()
    {
        var cliente = new Cliente(
            Guid.NewGuid(),
            "",
            "",
            DateTime.Now,
            "edu2edu.com",
            true,
            DateTime.Now);

        return cliente;
    }

    public void Dispose()
    {
    }
}