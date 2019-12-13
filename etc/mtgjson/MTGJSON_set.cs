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
    public string commander { get; set; }
    public string duel      { get; set; }
    public string legacy    { get; set; }
    public string modern    { get; set; }
    public string pauper    { get; set; }
    public string penny     { get; set; }
    public string vintage   { get; set; }
    public string frontier  { get; set; }
    public string future    { get; set; }
    public string standard  { get; set; }
}

public class Paper
{
    // Pricing data, currently not used
}
public class PaperFoil
{
    // Pricing data, currently not used
}

public class Prices
{
    public Paper     paper     { get; set; }
    public PaperFoil paperFoil { get; set; }
}

public class PurchaseUrls
{
    public string cardmarket { get; set; }
    public string mtgstocks  { get; set; }
    public string tcgplayer  { get; set; }

}
public class Rulings {
    public string date { get; set; }
    public string text { get; set; }
}
public class Card {
    public string             artist                 { get; set; }
    public string             borderColor            { get; set; }
    public IList<string>      colorIdentity          { get; set; }
    public IList<string>      colors                 { get; set; }
    public double             convertedManaCost      { get; set; }
    public string             flavorText             { get; set; }
    public IList<ForeignData> foreignData            { get; set; }
    public string             frameVersion           { get; set; }
    public bool               hasFoil                { get; set; }
    public bool               hasNonFoil             { get; set; }
    public bool               isMtgo                 { get; set; }
    public bool               isPaper                { get; set; }
    public string             layout                 { get; set; }
    public Legalities         legalities             { get; set; }
    public string             manaCost               { get; set; }
    public int                mcmId                  { get; set; }
    public int                mcmMetaId              { get; set; }
    public int                mtgoFoilId             { get; set; }
    public int                mtgoId                 { get; set; }
    public int                mtgstocksId            { get; set; }
    public int                multiverseId           { get; set; }
    public string             name                   { get; set; }
    public string             number                 { get; set; }
    public string             originalText           { get; set; }
    public string             originalType           { get; set; }
    public Prices             prices                 { get; set; }
    public IList<string>      printings              { get; set; }
    public PurchaseUrls       purchaseUrls           { get; set; }
    public string             rarity                 { get; set; }
    public IList<Ruling>      rulings                { get; set; }
    public string             scryfallId             { get; set; }
    public string             scryfallIllustrationId { get; set; }
    public string             scryfallOracleId       { get; set; }
    public IList<string>      subtypes               { get; set; }
    public IList<string>      supertypes             { get; set; }
    public int                tcgplayerProductId     { get; set; }
    public string             tcgplayerPurchaseUrl   { get; set; }
    public string             text                   { get; set; }
    public string             type                   { get; set; }
    public IList<string>      types                  { get; set; }
    public string             uuid                   { get; set; }
    public string             power                  { get; set; }
    public string             toughness              { get; set; }
    public IList<object>      names                  { get; set; }
    public bool?              isReprint              { get; set; }
    public string             loyalty                { get; set; }
    public bool?              isFullArt              { get; set; }
    public IList<string>      variations             { get; set; }
    public ThaumaturgeJson    thaumaturges           { get; set; }
}

public class Meta
{
    public string date       { get; set; }
    public string pricesDate { get; set; }
    public string version    { get; set; }
}

public class Tokens
{
    public string        artist                 { get; set; }
    public string        borderColor            { get; set; }
    public IList<string> colorIdentity          { get; set; }
    public IList<string> colors                 { get; set; }
    public string        layout                 { get; set; }
    public string        name                   { get; set; }
    public string        number                 { get; set; }
    public string        power                  { get; set; }
    public IList<string> reverseRelated         { get; set; }
    public string        scryfallId             { get; set; }
    public string        scryfallIllustrationId { get; set; }
    public string        scryfallOracleId       { get; set; }
    public string        text                   { get; set; }
    public string        toughness              { get; set; }
    public string        type                   { get; set; }
    public string        uuid                   { get; set; }
}

public class Translations
{
    // Translation data, currently not used
}

public class MtgJsonSet
{
    public int           baseSetSize      { get; set; }
    public string        block            { get; set; }
    public IList<object> boosterV3        { get; set; }
    public IList<Card>   cards            { get; set; }
    public string        code             { get; set; }
    public bool          isFoilOnly       { get; set; }
    public bool          isOnlineOnly     { get; set; }
    public string        keyruneCode      { get; set; }
    public int           mcmId            { get; set; }
    public string        mcmName          { get; set; }
    public Meta          meta             { get; set; }
    public string        mtgoCode         { get; set; }
    public string        name             { get; set; }
    public string        releaseDate      { get; set; }
    public int           tcgplayerGroupId { get; set; }
    public IList<Token>  tokens           { get; set; }
    public int           totalSetSize     { get; set; }
    public Translations  translations     { get; set; }
    public string        type             { get; set; }
}