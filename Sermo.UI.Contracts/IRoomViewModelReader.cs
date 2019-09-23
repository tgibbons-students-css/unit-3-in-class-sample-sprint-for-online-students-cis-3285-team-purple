using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sermo.UI.Contracts
{
    public interface IRoomViewModelReader
    {
        IEnumerable<RoomViewModel> GetAllRooms();
        // Changes Sprint 1 -- "I want to create rooms for categorizing conversations." -Julie Braford
        // Changes Sprint 1 -- "I want to create rooms for categorizing conversations." -- Derek Shaheen
        IEnumerable<MessageViewModel> GetRoomMessages(int roomID);
    }
}
