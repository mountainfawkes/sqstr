import subregions from '../../../Data/Subregions'
import countries from '../../../Data/Countries'

const electricityEstimateForm = () => {
  function handleElectricityInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.type.value,
      electricity_unit: event.target.electricity_unit.value,
      electricity_value: event.target.electricity_value.value,
      country: event.target.country.value,
      state: event.target.state.value,
    }
    console.log(data)
    fetch(`http://localhost:5000/api/Electricities`, {
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
      <h3>This is the electricity form</h3>
      <form onSubmit={handleElectricityInput}>
        <input type='hidden' name='type' value='electricity' />
        <input type='hidden' name='electricity_unit' value='mwh' />
        <label htmlFor='electricity_value'>Electricity usage (in MWh):
          <input name='electricity_value' type='number' step='0.01' min='0' />
        </label>
        <label htmlFor='country'>Country:
          <select name='country'>
            {countries.map(country => <option
              value={country.code}
            >
              {country.name}
            </option>)
            }
          </select>
        </label>
        <label htmlFor='state'>State:
          <select name='state'>
            {subregions.map(subregion => <option
              value={subregion.code}
            >
              {subregion.name}
            </option>)
            }
          </select>
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </div>
  )
}

export default electricityEstimateForm
