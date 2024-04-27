﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;
