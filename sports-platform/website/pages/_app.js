import '../styles/globals.css'
import { QueryClient, QueryClientProvider } from '@tanstack/react-query'

const queryClient = new QueryClient()

export default function App({ Component, pageProps }) {
  return (
    <QueryClientProvider client={queryClient}>
      <Component {...pageProps} />
    </QueryClientProvider>
  )
}

const apiUrl = process.env.NEXT_PUBLIC_API_URL;
axios.defaults.baseURL = apiUrl;