#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
	[global::Uno.NotImplemented]
#endif
	public partial interface IContentTypeProvider
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		string ContentType
		{
			get;
		}
#endif
		// Forced skipping of method Windows.Storage.Streams.IContentTypeProvider.ContentType.get
	}
}
