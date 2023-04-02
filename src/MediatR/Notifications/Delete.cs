/*
 * DeletedNotification.cs
 *
 *   Created: 2022-12-21-10:01:23
 *   Modified: 2022-12-21-10:02:34
 *
 *   Author: David G. Moore, Jr. <justin@Dgmjr.com>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Notifications;

public record struct DeletedNotification<TId, TDto> : IDeletedNotification<TId, TDto>
    where TId : IComparable, IEquatable<TId>
{
    public DeletedNotification(TDto dto, TId id)
    {
        Dto = dto;
        Id = id;
    }

    public TDto Dto { get; }
    public TId Id { get; }
}
