import singleSpaBlazor from 'blazor-wasm-single-spa';

// Build the asset base URL from this JavaScript module's URL. The asset base URL must have a
// trailing slash for Blazor to apply it correctly.
const iLastSlash = import.meta.url.lastIndexOf('/');
const assetBaseUrl = import.meta.url.substring(0, iLastSlash + 1);
console.log({ assetBaseUrl })

export const { bootstrap, mount, unmount } = singleSpaBlazor({
  appTagName: 'my-app',
  stylePaths: ['CatalogApp.styles.css'],
  assetBaseUrl,
});
