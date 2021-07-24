// import Select from 'react-select'
import airports from '../../../Data/Airports'

// eslint-disable-next-line no-lone-blocks
// <Select
//   options={airports}
//   onChange={opt => value = opt.code}
// />

// Need to add an event listener to add legs to request

const flightEstimateForm = () => {
  function handleFlightInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.flight.value,
      passengers: event.target.passengers.value,
      legs: [
        { departure_airport: event.target.departure_airport.value,
          destination_airport: event.target.destination_airport.value },
      ],
    }
    console.log(data)
    fetch(`http://localhost:5000/api/Attributes`, {
      method: `POST`,
      body: JSON.stringify(data),
      headers: {
        'Content-Type': `application/json`,
      },
    })
      .then(response => response.json())
      .then(json => console.log(json.data))
  }

  return (
    <div>
      <h3>This is the flight form</h3>
      <form onSubmit={handleFlightInput}>
        <input type='hidden' name='flight' value='flight' />
        <label htmlFor='passengers'>Number of passengers:
          <input name='passengers' type='number' min='1' />
        </label>
        <label htmlFor='departure_airport'>Departure airport:
          <select
            name='departure_airport'
          >
            {airports.map(airport =>
              <option value={airport.value}>
                {
            airport.value
            }: {
            airport.label
            }
              </option>)}
          </select>
        </label>
        <label htmlFor='destination_airport'>Destination airport:
          <select
            name='destination_airport'
          >
            {airports.map(airport =>
              <option value={airport.value}>
                {
            airport.value
            }: {
            airport.label
            }
              </option>)}
          </select>
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </div>
  )
}

export default flightEstimateForm
