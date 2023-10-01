/*
 * IUpdatedNotification.cs
 *
 *   Created: 2022-12-21-10:01:45
 *   Modified: 2022-12-21-10:02:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Notifications;

public record struct UpdatedNotification<TDto> : IUpdatedNotification<TDto>
{
    public UpdatedNotification(TDto updateDto)
    {
        Updated = updateDto;
    }

    public TDto Updated { get; set; }
}
