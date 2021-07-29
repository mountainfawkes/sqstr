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

  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  const inputStyles = {
    display: `block`,
    margin: `5px`,
  }

  return (
    <div style={contentStyles}>
      <div style={{ backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif` }}
      >
        <p>
          What's the deal with airline food?
        </p>
        <form onSubmit={handleFlightInput}>
          <input type='hidden' name='flight' value='flight' />
          <input type='hidden' name='distance_unit' value='km' />
          <div style={inputStyles}>
            <label htmlFor='passengers'>Number of passengers:
              <input
                name='passengers'
                type='number'
                min='1'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='departure_airport'>Departure airport:
              <select
                name='departure_airport'
                style={{ display: `block`, margin: `0 0 0 10px` }}
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
          </div>
          <div style={inputStyles}>
            <label htmlFor='destination_airport'>Destination airport:
              <select
                name='destination_airport'
                style={{ display: `block`, margin: `0 0 0 10px` }}
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
          </div>
          <button type='submit' style={{ marginTop: `10px` }}>Estimate</button>
        </form>
      </div>
    </div>
  )
}

export default flightEstimateForm
