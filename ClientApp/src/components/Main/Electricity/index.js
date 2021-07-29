/* eslint-disable no-trailing-spaces */
import subregions from '../../../Data/Subregions'
import countries from '../../../Data/Countries'

const electricityEstimateForm = ({ formCallback,
  estimateCallback,
  estimateVisibilityCallback }) => {
  async function handleElectricityInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.type.value,
      electricity_unit: event.target.electricity_unit.value,
      electricity_value: event.target.electricity_value.value,
      country: event.target.country.value,
      state: event.target.state.value,
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
      <div style={{
        backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif`,
      }}
      >
        <p>
          Use the form below to estimate your carbon offset by electricity usage.
        </p>
        <form onSubmit={handleElectricityInput}>
          <input type='hidden' name='type' value='electricity' />
          <input type='hidden' name='electricity_unit' value='mwh' />
          <div style={inputStyles}>
            <label htmlFor='electricity_value'>Electricity used (in MWh):
              <input
                name='electricity_value' 
                type='number' 
                step='0.01' 
                min='0'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='country'>Country:
              <select 
                name='country' 
                style={{ margin: `0 0 0 10px` }}
              >
                {countries.map(country => <option
                  value={country.code}
                >
                  {country.name}
                </option>)
              }
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='state'>State:
              <select 
                name='state'
                style={{ margin: `0 0 0 10px` }}
              >
                {subregions.map(subregion => <option
                  value={subregion.code}
                >
                  {subregion.name}
                </option>)
              }
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <button type='submit' style={{ marginTop: `10px` }}>Estimate</button>
          </div>
        </form>
      </div>
    </div>
  )
}

export default electricityEstimateForm
