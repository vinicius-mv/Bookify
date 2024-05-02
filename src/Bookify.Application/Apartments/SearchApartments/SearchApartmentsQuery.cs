﻿using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.SearchApartments;

public sealed record class SearchApartmentsQuery(
    DateOnly StartDate,
    DateOnly EndDate
) : IQuery<IReadOnlyList<ApartmentResponse>>;
