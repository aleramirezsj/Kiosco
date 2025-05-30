﻿using Backend.Controllers;
using Backend.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Tests
{
    public class ClientesControllerTest
    {
        SqliteConnection connection = new SqliteConnection("DataSource=:memory:");
        DbContextOptions<KioscoContext> options;

        public ClientesControllerTest()
        {
            connection.Open();
            options = new DbContextOptionsBuilder<KioscoContext>()
                .UseSqlite(connection)
                .Options;
        }

        [Fact]
        public async void GetClientes()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();

                var clientesController = new ClientesController(context);
                
                //****ACT
                var result = await clientesController.GetClientes();
                //convierto el result en una lista
                var lista = result.Value.ToList();

                //***ASSERT
                //verifico que la lista no sea nula
                Assert.NotNull(lista);
                //verifico que la lista no este vacia
                Assert.NotEmpty(lista);
                //verifico que la lista tenga al menos un elemento
                Assert.True(lista.Count > 0);
                //verifico que la lista sea igual a 4
                Assert.Equal(5, lista.Count);
            }
            // Cerrar la conexión al finalizar
            connection.Close();

        }

        [Theory]
        [InlineData(1,"Juan Pérez")]
        [InlineData(2, "María López")]
        public async void GetCliente_JuanPerez_y_Maria_Lopez(int idGet, string valueExpect)
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                //***ACT
                var result = await clientesController.GetCliente(idGet);

                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo OkObjectResult
                //verifico que el resultado no sea de tipo NotFoundResult
                Assert.IsNotType<NotFoundResult>(result.Result);
                //verifico que el resultado no sea de tipo BadRequestResult
                Assert.IsNotType<BadRequestResult>(result.Result);
                //verifico que el resultado no sea de tipo NoContentResult
                Assert.IsNotType<NoContentResult>(result.Result);
                //verifico que el resultado no sea de tipo StatusCodeResult
                Assert.IsNotType<StatusCodeResult>(result.Result);
                //verifico que el resultado no sea de tipo UnauthorizedResult
                Assert.IsNotType<UnauthorizedResult>(result.Result);
                //verifico que el resultado no sea de tipo ForbidResult
                Assert.IsNotType<ForbidResult>(result.Result);
                //verifico que el resultado no sea de tipo ConflictResult
                Assert.IsNotType<ConflictResult>(result.Result);
                //verifico que el resultado no sea de tipo CreatedResult
                Assert.IsNotType<CreatedResult>(result.Result);
                //verifico que el resultado no sea de tipo AcceptedResult
                Assert.IsNotType<AcceptedResult>(result.Result);
                //verifico que el resultado no sea de tipo NotFoundObjectResult
                Assert.IsNotType<NotFoundObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo BadRequestObjectResult
                Assert.IsNotType<BadRequestObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo ObjectResult
                Assert.IsNotType<ObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo UnauthorizedObjectResult
                Assert.IsNotType<UnauthorizedObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo ConflictObjectResult
                Assert.IsNotType<ConflictObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo OkResult
                Assert.IsNotType<OkResult>(result.Result);
                //transformo el resultado en un objeto Localidad
                var cliente = result.Value as Cliente;
                //verifico que el objeto no sea nulo
                Assert.NotNull(cliente);
                //verifico que el objeto no sea vacio
                Assert.NotEmpty(cliente.Nombre);
                //verifico que sea igual a "San Justo"
                Assert.Equal(valueExpect, cliente.Nombre);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact(Skip ="Este test ya lo estamos probando en el test hecho con Theory")]
        public async void GetCliente_JuanPerez()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                //***ACT
                var result = await clientesController.GetCliente(1);

                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo OkObjectResult
                //verifico que el resultado no sea de tipo NotFoundResult
                Assert.IsNotType<NotFoundResult>(result.Result);
                //verifico que el resultado no sea de tipo BadRequestResult
                Assert.IsNotType<BadRequestResult>(result.Result);
                //verifico que el resultado no sea de tipo NoContentResult
                Assert.IsNotType<NoContentResult>(result.Result);
                //verifico que el resultado no sea de tipo StatusCodeResult
                Assert.IsNotType<StatusCodeResult>(result.Result);
                //verifico que el resultado no sea de tipo UnauthorizedResult
                Assert.IsNotType<UnauthorizedResult>(result.Result);
                //verifico que el resultado no sea de tipo ForbidResult
                Assert.IsNotType<ForbidResult>(result.Result);
                //verifico que el resultado no sea de tipo ConflictResult
                Assert.IsNotType<ConflictResult>(result.Result);
                //verifico que el resultado no sea de tipo CreatedResult
                Assert.IsNotType<CreatedResult>(result.Result);
                //verifico que el resultado no sea de tipo AcceptedResult
                Assert.IsNotType<AcceptedResult>(result.Result);
                //verifico que el resultado no sea de tipo NotFoundObjectResult
                Assert.IsNotType<NotFoundObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo BadRequestObjectResult
                Assert.IsNotType<BadRequestObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo ObjectResult
                Assert.IsNotType<ObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo UnauthorizedObjectResult
                Assert.IsNotType<UnauthorizedObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo ConflictObjectResult
                Assert.IsNotType<ConflictObjectResult>(result.Result);
                //verifico que el resultado no sea de tipo OkResult
                Assert.IsNotType<OkResult>(result.Result);
                //transformo el resultado en un objeto Localidad
                var cliente = result.Value as Cliente;
                //verifico que el objeto no sea nulo
                Assert.NotNull(cliente);
                //verifico que el objeto no sea vacio
                Assert.NotEmpty(cliente.Nombre);
                //verifico que sea igual a "San Justo"
                Assert.Equal("Juan Pérez", cliente.Nombre);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void GetCliente_NoFound()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                //***ACT
                var result = await clientesController.GetCliente(1000);
                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo NotFoundResult
                Assert.IsType<NotFoundResult>(result.Result);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }

        [Fact]
        public async void PutCliente_BadRequest_ArgumentNull()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                //*** Arrange
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                var cliente= new Cliente()
                {
                    Id = 1,
                    Nombre = "Juan Pérez",
                    Direccion = "Av. Rivadavia 1234",
                    Telefonos = "011-12345678",
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    LocalidadId = 1,
                    Eliminado = false
                };
                //***ACT
                //verifico que el resultado sea de tipo BadRequest
                var result = await clientesController.PutCliente(null, cliente );
                Assert.IsType<BadRequestResult>(result);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void PutCliente_ArgumentNullException()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                //***ACT
                //verifico que el resultado sea de tipo ArgumentNullException
                await Assert.ThrowsAsync<ArgumentNullException>(async () => await clientesController.PutCliente(1, null));
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void DeleteCliente_NotFound_Mock()
        {
            //*** arrange
            var context= new Mock<KioscoContext>(options);
            context.Setup(c => c.Clientes.FindAsync(It.IsAny<int?>())).ReturnsAsync((Cliente)null);
            var clientesController = new ClientesController(context.Object);
            //***ACT
            var result = await clientesController.DeleteCliente(1000);
            //***ASSERT
            //verifico que el resultado sea NotFound
            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public async void DeleteCliente_Id_1()
        {
            //*** arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                //***ACT
                var result = await clientesController.DeleteCliente(1);
                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo OkObjectResult
                Assert.IsType<NoContentResult>(result);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void PostCliente()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                var cliente = new Cliente()
                {
                    Nombre = "Juan Fernandez",
                    Direccion = "Av. Rivadavia 1234",
                    Telefonos = "011-12345678",
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    LocalidadId = 1,
                    Eliminado = false
                };
                //***ACT
                var result = await clientesController.PostCliente(cliente);
                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo CreatedAtActionResult
                Assert.IsType<CreatedAtActionResult>(result.Result);
                //verifico que llega un objeto del tipo cliente


            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void PutCliente()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                var cliente = new Cliente()
                {
                    Id = 1,
                    Nombre = "Monica Mellano",
                    Direccion = "Av. Rivadavia 1234",
                    Telefonos = "011-12345678",
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    LocalidadId = 1,
                    Eliminado = false
                };
                //***ACT
                var result = await clientesController.PutCliente(1, cliente);
                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo NoContentResult
                Assert.IsType<NoContentResult>(result);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async void PutCliente_BadRequest()
        {
            //*** Arrange
            // Crear la base de datos y aplicar las migraciones
            using (var context = new KioscoContext(options))
            {
                context.Database.EnsureCreated();
                var clientesController = new ClientesController(context);
                var cliente = new Cliente()
                {
                    Id = 1,
                    Nombre = "Juan Perez",
                    Direccion = "Av. Rivadavia 1234",
                    Telefonos = "011-12345678",
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    LocalidadId = 1,
                    Eliminado = false
                };
                //***ACT
                var result = await clientesController.PutCliente(1000, cliente);
                //***ASSERT
                //verifico que el resultado no sea nulo
                Assert.NotNull(result);
                //verifico que el resultado sea de tipo BadRequestResult
                Assert.IsType<BadRequestResult>(result);
            }
            // Cerrar la conexión al finalizar
            connection.Close();
        }
        [Fact]
        public async Task PutCliente_DbUpdateConcurrencyException_ClienteNoExiste_RetornaNotFound()
        {
            // Arrange
            var cliente = new Cliente { Id = 1 };

            // 1) Creamos una IQueryable<Cliente> vacía
            var datos = new List<Cliente>().AsQueryable();
            var mockSet = new Mock<DbSet<Cliente>>();
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.Provider).Returns(datos.Provider);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.Expression).Returns(datos.Expression);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.ElementType).Returns(datos.ElementType);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.GetEnumerator()).Returns(datos.GetEnumerator());

            // 2) Mockeamos el contexto
            var mockContext = new Mock<KioscoContext>(options);
            mockContext.Setup(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()))
                       .ThrowsAsync(new DbUpdateConcurrencyException());
            mockContext.Setup(c => c.Clientes).Returns(mockSet.Object);

            // 3) Configuramos el método Any() para que devuelva false (cliente no existe)
            mockSet.Setup(m => m.Any(It.IsAny<Expression<Func<Cliente, bool>>>())).Returns(false);

            var controller = new ClientesController(mockContext.Object);

            // Act
            var result = await controller.PutCliente(1, cliente);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }



        [Fact]
        public async Task PutCliente_DbUpdateConcurrencyException_ClienteExiste_LanzaExcepcion()
        {
            // Arrange
            var cliente = new Cliente { Id = 1 };

            // 1) Creamos una IQueryable<Cliente> con un solo elemento
            var datos = new List<Cliente> { cliente }.AsQueryable();
            var mockSet = new Mock<DbSet<Cliente>>();
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.Provider).Returns(datos.Provider);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.Expression).Returns(datos.Expression);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.ElementType).Returns(datos.ElementType);
            mockSet.As<IQueryable<Cliente>>().Setup(m => m.GetEnumerator()).Returns(datos.GetEnumerator());

            // 2) Mockeamos el contexto igual que antes
            var mockContext = new Mock<KioscoContext>(options);
            mockContext
               .Setup(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()))
               .ThrowsAsync(new DbUpdateConcurrencyException());
            mockContext.Setup(c => c.Clientes).Returns(mockSet.Object);

            var controller = new ClientesController(mockContext.Object);

            // Act & Assert
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(
                () => controller.PutCliente(1, cliente)
            );
        }






    }
}
