import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';

export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      '/api': {
        target: 'https://swapi.co', // SWAPI.co API'yi kullanıyoruz
        changeOrigin: true,         // Origin başlığını değiştirmek
        rewrite: (path) => path.replace(/^\/api/, ''), // /api'yi kaldırmak
        secure: true, // HTTPS ile iletişim sağlamak
      },
    },
  },
});
