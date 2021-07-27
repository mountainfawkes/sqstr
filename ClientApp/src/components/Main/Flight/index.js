// import Select from 'react-select'
import airports from '../../../Data/Airports'

// eslint-disable-next-line no-lone-blocks
// <Select
//   options={airports}
//   onChange={opt => value = opt.code}
// />

// Need to add an event listener to add legs to request

const flightEstimateForm = ({ formCallback,
  estimateCallback,
  estimateVisibilityCallback }) => {
  async function handleFlightInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.flight.value,
      distance_unit: event.target.distance_unit.value,
      passengers: parseInt(event.target.passengers.value, 10),
      legs: [
        { departure_airport: event.target.departure_airport.value,
          destination_airport: event.target.destination_airport.value },
      ],
    }
    console.log(data)
    await fetch(`http://localhost:5000/api/Attributes`, {
      method: `POST`,
      body: JSON.stringify(data),
      headers: {
        'Content-Type': `application/json`,
      },
    })
      .then(response => response.json())
      .then(data => estimateCallback(data))
      .then(data => console.log(data))

    formCallback(null)
    estimateVisibilityCallback(true)
  }

  return (
    <div>
      <h3>This is the flight form</h3>
      <form onSubmit={handleFlightInput}>
        <input type='hidden' name='flight' value='flight' />
        <input type='hidden' name='distance_unit' value='km' />
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
