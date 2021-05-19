using System.Threading.Tasks;

namespace Zaabee.ZeroMQ.Abstraction.Socket.RequestReply
{
    public interface IClientSocket
    {
        void Send<T>(T message);
        Task SendAsync<T>(T message);
    }
}