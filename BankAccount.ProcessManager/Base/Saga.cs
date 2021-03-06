﻿using System;
using BankAccount.Infrastructure.Buses;
using BankAccount.Infrastructure.Storage;

namespace BankAccount.ProcessManager.Base
{
    public abstract class Saga
    {
        #region Properties

        protected Guid SagaId { get; set; }
        protected IBus Bus { get; private set; }
        protected ICommandStackRepository Repository { get; private set; }

        #endregion

        #region C-Tor

        protected Saga(
            IBus bus, 
            ICommandStackRepository repository)
        {
            if (bus == null)
            {
                throw new ArgumentNullException($"bus");
            }

            if (repository == null)
            {
                throw new ArgumentNullException($"repository");
            }

            this.Bus = bus;
            this.Repository = repository;
        }

        #endregion
    }
}
