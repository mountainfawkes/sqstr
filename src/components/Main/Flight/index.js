import Select from 'react-select'
import airports from '../../../Data/FlightLocations'

const airportKeys = airports.map(({ iata, name }) => ({ iata, name }))

export default () => (
  <div>
    <h3>This is the flight form</h3>
    <form onSubmit='undefined'>
      <input type='hidden' value='flight' />
      <label htmlFor='passengers'>Number of passengers:
        <input name='passengers' type='number' />
      </label>
      <label htmlFor='departure-airport'>Departure airport:
        <select
          name='departure-airport'
          placeholder='PDX - Portland International Airport'
        >
          {airports.map(airport =>
            <option value={airport.iata}>
              {
            airport.iata
            } {
            airport.name
            }
            </option>)}
          <option value='pdx'>PDX - Portland International Airport</option>
        </select>
      </label>
      <label htmlFor='destination-airport'>Destination airport:
        <select
          name='destination-airport'
          placeholder='SFO - San Francisco International Airport'
        >
          {airports.map(airport =>
            <option value={airport.iata}>
              {
            airport.iata
            } {
            airport.name
            }
            </option>)}
        </select>
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </div>
)
