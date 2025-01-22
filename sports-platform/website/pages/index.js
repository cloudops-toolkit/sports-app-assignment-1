import { useQuery } from '@tanstack/react-query'
import axios from 'axios'

export default function Home() {
  const { data, isLoading } = useQuery({
    queryKey: ['sports'],
    queryFn: () => axios.get('/api/sports').then(res => res.data)
  })

  if (isLoading) return <div>Loading...</div>

  return (
    <div className="p-4">
      <h1 className="text-2xl font-bold mb-4">Sports Platform</h1>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
        {data?.map(sport => (
          <div key={sport.id} className="border p-4 rounded shadow">
            <h2 className="text-xl font-semibold">{sport.name}</h2>
            <p className="text-gray-600">{sport.description}</p>
          </div>
        ))}
      </div>
    </div>
  )
}