﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sermo.UI.Contracts;

namespace Sermo.Markdown
{
    using Markdown=MarkdownDeep.Markdown;

    public class RoomViewModelReaderMarkdownDecorator : IRoomViewModelReader
    {
        public RoomViewModelReaderMarkdownDecorator(IRoomViewModelReader @delegate, Markdown markdown)
        {
            this.@delegate = @delegate;
            this.markdown = markdown;
        }

        public IEnumerable<RoomViewModel> GetAllRooms()
        {
            return @delegate.GetAllRooms();
        }

        public IEnumerable<MessageViewModel> GetRoomMessages(int roomID)
        {
            var roomMessages = @delegate.GetRoomMessages(roomID);

            foreach(var viewModel in roomMessages)
            {
                viewModel.Text = markdown.Transform(viewModel.Text);
            }

            return roomMessages;
            //Changes Sprint 2 - I want to send markdown that will be correctly formatted. --Julie Braford
            //Changes Sprint 2 - I want to send markdown that will be correctly formatted. -- Derek Shaheen
        }

        private readonly IRoomViewModelReader @delegate;
        private readonly Markdown markdown;
    }
}
