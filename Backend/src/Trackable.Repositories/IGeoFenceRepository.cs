// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Trackable.EntityFramework;
using Trackable.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Trackable.Repositories
{
    /// <summary>
    /// Responsible for handling the Geofence repository.
    /// </summary>
    public interface IGeoFenceRepository : 
        IRepository<int, GeoFence>,
        IDbCountableRepository<int, GeoFenceData, GeoFence>,
        IDbNamedRepository<int, GeoFenceData, GeoFence>,
        IDbTaggedRepository<int, GeoFenceData, GeoFence>
    {
        Task<Dictionary<GeoFence, bool>> GetByAssetIdWithIntersectionAsync(string assetId, IPoint[] points);

        Task<GeoFence> UpdateAssetsAsync(GeoFence fence, IEnumerable<string> assetIds);
    }
}
