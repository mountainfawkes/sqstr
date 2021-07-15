// import Select from 'react-select'
import airports from '../../../Data/Airports'

// eslint-disable-next-line no-lone-blocks
{ /* this block is a Select element that implements searchable Select,
  but it needs a lot of work
  <Select
options={airports}
/>
*/ }

const flightEstimate = () => {
  function handleInput(event) {
    event.preventDefault()
    return console.log({
      "type": event.target.flight.value,
      "passengers": event.target.passengers.value,
      "legs": [
        { "departure_airport": event.target.departure_airport.value,
          "destination_airport": event.target.destination_airport.value },
      ],
    })
  }

  return (
    <div>
      <h3>This is the flight form</h3>
      <form onSubmit={handleInput}>
        <input type='hidden' name='flight' value='flight' />
        <label htmlFor='passengers'>Number of passengers:
          <input name='passengers' type='number' />
        </label>
        <label htmlFor='departure-airport'>Departure airport:
          <select
            name='departure-airport'
            placeholder='PDX - Portland International Airport'
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
        <label htmlFor='destination-airport'>Destination airport:
          <select
            name='destination-airport'
            placeholder='SFO - San Francisco International Airport'
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

export default flightEstimate
