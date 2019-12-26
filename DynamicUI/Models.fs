namespace DynamicUI

module Models =
    type Music =
        { ImageUrl: string
          ArtistName: string
          Genre: string
          TrackName: string
          Country: string }

    type Remote<'t> =
        | Loading
        | Content of 't
