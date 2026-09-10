// Service Worker simples para cache do "app shell"
// Comentários em português explicando as etapas

const CACHE_NAME = 'senacgames-cache-v1';
// Arquivos essenciais que serão cacheados durante a instalação
const OFFLINE_URLS = [
    '/',
    '/css/site.css',
    '/js/theme.js',
    '/images/logo.png',
    '/icons/icon-192.png',
    '/icons/icon-512.png',
    '/offline.html'
];

// Evento install: cacheia os recursos essenciais
self.addEventListener('install', event => {
    event.waitUntil(
        caches.open(CACHE_NAME)
            .then(cache => cache.addAll(OFFLINE_URLS))
    );
    self.skipWaiting(); // ativa imediatamente
});

// Evento activate: limpa caches antigos
self.addEventListener('activate', event => {
    event.waitUntil(
        caches.keys().then(keys =>
            Promise.all(keys.map(key => {
                if (key !== CACHE_NAME) return caches.delete(key);
            }))
        )
    );
    self.clients.claim();
});

// Evento fetch: responde do cache ou da rede (fallback para '/')
self.addEventListener('fetch', event => {
    if (event.request.method !== 'GET') return;
    event.respondWith(
        caches.match(event.request).then(cachedResponse => {
            if (cachedResponse) return cachedResponse;
            return fetch(event.request).catch(() => caches.match('/'));
        })
    );
});