namespace CartprojectG2
{
    
        public interface IUserOrderRepository
        {
            Task<IEnumerable<Order>> UserOrders();
        }
    }
