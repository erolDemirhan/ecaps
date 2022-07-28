import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ecaps',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44332/',
    redirectUri: baseUrl,
    clientId: 'ecaps_App',
    responseType: 'code',
    scope: 'offline_access ecaps',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'ecaps',
    },
  },
} as Environment;
