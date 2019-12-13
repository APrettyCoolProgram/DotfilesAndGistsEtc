namespace YourNamespace
{
    public class MtgJsonSet
    {
        public int          baseSetSize      { get; set; }
        public string       block            { get; set; }
        public List<object> boosterV3        { get; set; }
        public List<Card>   cards            { get; set; }
        public string       code             { get; set; }
        public string       codeV3           { get; set; }
        public bool         isForeignOnly    { get; set; }
        public bool         isFoilOnly       { get; set; }
        public bool         isOnlineOnly     { get; set; }
        public bool         isPartialPreview { get; set; }
        public string       keyruneCode      { get; set; }
        public int          mcmId            { get; set; }
        public string       mcmName          { get; set; }
        public Meta         meta             { get; set; }
        public string       mtgoCode         { get; set; }
        public string       name             { get; set; }
        public string       parentCode       { get; set; }
        public string       releaseDate      { get; set; }
        public int          tcgplayerGroupId { get; set; }
        public List<Tokens> tokens           { get; set; }
        public int          totalSetSize     { get; set; }
        public Translations translations     { get; set; }
        public string       type             { get; set; }

        //////public class BoosterV3
        //////{
        //////    public List<string> slotOne  { get; set; }
        //////    public string slotTwo { get; set; }
        //////}

        public class Card
        {
            public string            artist                 { get; set; }
            public string            borderColor            { get; set; }
            public List<string>      colorIdentity          { get; set; }
            public List<string>      colorIndicator         { get; set; }
            public List<string>      colors                 { get; set; }
            public double            convertedManaCost      { get; set; }
            public int               count                  { get; set; }
            public string            duelDeck               { get; set; }
            public int               edhrecRank             { get; set; }
            public double            faceConvertedManaCost  { get; set; }
            public string            flavorText             { get; set; }
            public List<ForeignData> foreignData            { get; set; }
            public string            frameEffect            { get; set; }
            public string            frameVersion           { get; set; }
            public string            hand                   { get; set; }
            public bool              hasFoil                { get; set; }
            public bool              hasNonFoil             { get; set; }
            public bool              isAlternative          { get; set; }
            public bool              isArena                { get; set; }
            public bool              isFullArt              { get; set; }
            public bool              isMtgo                 { get; set; }
            public bool              isOnlineOnly           { get; set; }
            public bool              isOversized            { get; set; }
            public bool              isPaper                { get; set; }
            public bool              isPromo                { get; set; }
            public bool              isReprint              { get; set; }
            public bool              isReserved             { get; set; }
            public bool              isStarter              { get; set; }
            public bool              isStorySpotlight       { get; set; }
            public bool              isTimeshifted          { get; set; }
            public string            layout                 { get; set; }
            public Legalities        legalities             { get; set; }
            public string            life                   { get; set; }
            public string            loyalty                { get; set; }
            public string            manaCost               { get; set; }
            public int               mcmId                  { get; set; }
            public int               mcmMetaId              { get; set; }
            public string            mcmName                { get; set; }
            public int               mtgArenaId             { get; set; }
            public int               mtgoFoilId             { get; set; }
            public int               mtgoId                 { get; set; }
            public int               mtgstocksId            { get; set; }
            public int               multiverseId           { get; set; }
            public string            name                   { get; set; }
            public List<string>      names                  { get; set; }
            public string            number                 { get; set; }
            public string            originalText           { get; set; }
            public string            originalType           { get; set; }
            public string            power                  { get; set; }
            public Prices            prices                 { get; set; }
            public List<string>      printings              { get; set; }
            public PurchaseUrls      purchaseUrls           { get; set; }
            public string            rarity                 { get; set; }
            public List<Rulings>     rulings                { get; set; }
            public string            scryfallId             { get; set; }
            public string            scryfallIllustrationId { get; set; }
            public string            scryfallOracleId       { get; set; }
            public string            side                   { get; set; }
            public List<string>      subtypes               { get; set; }
            public List<string>      supertypes             { get; set; }
            public int               tcgplayerProductId     { get; set; }
            public string            tcgplayerPurchaseUrl   { get; set; }
            public string            text                   { get; set; }
            public string            toughness              { get; set; }
            public string            type                   { get; set; }
            public List<string>      types                  { get; set; }
            public string            uuid                   { get; set; }
            public List<string>      variations             { get; set; }
            public string            watermark              { get; set; }
        }

        public class ForeignData
        {
            public string flavorText   { get; set; }
            public string language     { get; set; }
            public int    multiverseId { get; set; }
            public string name         { get; set; }
            public string text         { get; set; }
            public string type         { get; set; }
        }

        public class Legalities
        {
            public string brawl     { get; set; }
            public string commander { get; set; }
            public string duel      { get; set; }
            public string frontier  { get; set; }
            public string future    { get; set; }
            public string legacy    { get; set; }
            public string modern    { get; set; }
            public string pauper    { get; set; }
            public string penny     { get; set; }
            public string standard  { get; set; }
            public string vintage   { get; set; }
        }

        public class Prices
        {
            public Paper     paper     { get; set; }
            public PaperFoil paperFoil { get; set; }
        }

        public class Paper
        {
            /* Not currently used */
        }
        public class PaperFoil
        {
            /* Not currently used */
        }

        public class PurchaseUrls
        {
            public string cardmarket { get; set; }
            public string mtgstocks  { get; set; }
            public string tcgplayer  { get; set; }
        }

        public class Rulings
        {
            public string date { get; set; }
            public string text { get; set; }
        }

        public class Meta
        {
            public string date       { get; set; }
            public string pricesDate { get; set; }
            public string version    { get; set; }
        }

        public class Tokens
        {
            public string       artist                 { get; set; }
            public string       borderColor            { get; set; }
            public List<string> colorIdentity          { get; set; }
            public List<string> colorIndicator         { get; set; }
            public List<string> colors                 { get; set; }
            public bool         isOnlineOnly           { get; set; }
            public string       layout                 { get; set; }
            public string       loyalty                { get; set; }
            public string       name                   { get; set; }
            public List<string> names                  { get; set; }
            public string       number                 { get; set; }
            public string       power                  { get; set; }
            public List<string> reverseRelated         { get; set; }
            public string       scryfallId             { get; set; }
            public string       scryfallIllustrationId { get; set; }
            public string       scryfallOracleId       { get; set; }
            public string       side                   { get; set; }
            public string       text                   { get; set; }
            public string       toughness              { get; set; }
            public string       type                   { get; set; }
            public string       uuid                   { get; set; }
            public string       watermark              { get; set; }
        }

        public class Translations
        {
            /* Not currently used */
        }