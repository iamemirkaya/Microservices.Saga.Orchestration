using MassTransit;
using SagaStateMachine.Service.StateInstances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaStateMachine.Service.StateMaps
{
    public class OrderStateMap : SagaClassMap<OrderStateInstance>
    {
    }
}
