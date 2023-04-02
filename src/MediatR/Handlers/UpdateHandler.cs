/*
 * UpdateHandler.cs
 *
 *   Created: 2022-12-26-10:55:19
 *   Modified: 2022-12-26-10:55:39
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR;

using Dgmjr.MediatR.Handlers.Abstractions;

public class UpdateHandler<TModel, TDbContext, TUpdateDto, TViewDto, TId>
    : IHaveADbContext<TDbContext>,
        IUpdateHandler<UpdateCommand<TModel, TId, TUpdateDto, TViewDto>, TId, TModel, TUpdateDto, TViewDto>
    where TDbContext : DbContext, IDbContext<TDbContext>
    where TModel : class, IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
    where TViewDto : IIdentifiable<TId>
{
    public virtual IMediator Mediator { get; }
    public virtual TDbContext Db { get; }
    public virtual IMapper Mapper { get; }
    IDbContext IHaveADbContext.Db => throw new NotImplementedException();

    public UpdateHandler(IMediator mediator, TDbContext dbContext, IMapper mapper)
    {
        Mediator = mediator;
        Db = dbContext;
        Mapper = mapper;
    }

    public Task<TViewDto> Handle(UpdateCommand<TModel, TId, TUpdateDto, TViewDto> request, CancellationToken cancellationToken)
    {
        var model = Db.Set<TModel>().Find(request.Update);
        Mapper.Map(request.Update, model);
        Db.Set<TModel>().Update(model);
        Db.SaveChanges();
        var dto = Mapper.Map<TViewDto>(model);
        Mediator.Publish(new UpdatedNotification<TViewDto>(dto), cancellationToken);
        return Task.FromResult(dto);
    }
}
