// import Select from 'react-select'
import airports from '../../../Data/Airports'

// eslint-disable-next-line no-lone-blocks
{ /* this block is a Select element that implements searchable Select,
  but it needs a lot of work
  <Select
options={airports}
/>
*/ }

const flightEstimateForm = () => {
  function handleFlightInput(event) {
    event.preventDefault()
    return console.log({
      type: event.target.flight.value,
      passengers: event.target.passengers.value,
      legs: [
        { departure_airport: event.target.departure_airport.value,
          destination_airport: event.target.destination_airport.value },
      ],
    })
  }

  return (
    <div>
      <h3>This is the flight form</h3>
      <form onSubmit={handleFlightInput}>
        <input type='hidden' name='flight' value='flight' />
        <label htmlFor='passengers'>Number of passengers:
          <input name='passengers' type='number' />
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
