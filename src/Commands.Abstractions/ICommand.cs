/*
 * ICommand.cs
 *
 *   Created: 2022-12-21-09:57:16
 *   Modified: 2022-12-21-09:57:16
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.MediatR.Commands.Abstractions;

public interface ICommand<out TResponse> : IRequest<TResponse> { }
