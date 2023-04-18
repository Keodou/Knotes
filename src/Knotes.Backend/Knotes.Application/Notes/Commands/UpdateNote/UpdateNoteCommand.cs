﻿using MediatR;

namespace Knotes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest
    {
        public Guid UserId { get; set; }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }
    }
}
